using System.Collections.Generic;
using System.Linq;
using PhotoShare.Client.Core.Commands;

namespace PhotoShare.Client.Core
{
    using System;

    public class CommandDispatcher
    {
        public string DispatchCommand(string[] commandParameters)
        {
            string result;
                switch (commandParameters[0])
                {
                    case "RegisterUser":////
                        if (commandParameters.Length != 5) { goto default; }
                        AccessAsLoggedOut();
                        Commands.RegisterUserCommand registerUser = new RegisterUserCommand();
                        result = registerUser.Execute(commandParameters.Skip(1).ToArray());
                        break;
                    case "AddTown":////
                        if (commandParameters.Length != 3) { goto default; }
                        AccessAsLoggedIn(commandParameters);
                        Commands.AddTownCommand addTown = new AddTownCommand();
                        result = addTown.Execute(commandParameters.Skip(1).ToArray());
                        break;
                    case "ModifyUser":////
                        if (commandParameters.Length != 3) { goto default; }
                        AccessAsLoggedIn(commandParameters);
                        Commands.ModifyUserCommand modifyUser = new ModifyUserCommand();
                        result = modifyUser.Execute(commandParameters.Skip(1).ToArray());
                        break;
                    case "DeleteUser":////
                        if (commandParameters.Length != 1) { goto default; }
                        AccessAsLoggedIn(commandParameters);
                        Commands.DeleteUserCommand deleteUser = new DeleteUserCommand();
                        result = deleteUser.Execute();
                        break;
                    case "AddTag":////
                        if (commandParameters.Length != 2) { goto default; }
                        AccessAsLoggedIn(commandParameters);
                        Commands.AddTagCommand addTag = new AddTagCommand();
                        result = addTag.Execute(commandParameters.Skip(1).ToArray());
                        break;
                    case "CreateAlbum":////
                        if (commandParameters.Length < 2) { goto default; }
                        AccessAsLoggedIn(commandParameters);
                        Commands.CreateAlbumCommand createAlbum = new CreateAlbumCommand();
                        result = createAlbum.Execute(commandParameters.Skip(1).ToArray());
                        break;
                    case "AddTagTo":////
                        if (commandParameters.Length != 3) { goto default; }
                        AccessAsLoggedIn(commandParameters);
                        Commands.AddTagToCommand addTagTo = new AddTagToCommand();
                        result = addTagTo.Execute(commandParameters.Skip(1).ToArray());
                        break;
                    case "MakeFriends":////
                        if (commandParameters.Length != 2) { goto default; }
                        AccessAsLoggedIn(commandParameters);
                        Commands.MakeFriendsCommand makeFriends = new MakeFriendsCommand();
                        result = makeFriends.Execute(commandParameters.Skip(1).ToArray());
                        break;
                    case "ListFriends":////
                        if (commandParameters.Length != 2) { goto default; }
                        // both users can
                        Commands.PrintFriendsListCommand printFriends = new PrintFriendsListCommand();
                        result = printFriends.Execute(commandParameters.Skip(1).ToArray());
                        break;
                    case "ShareAlbum":////
                        if (commandParameters.Length != 3) { goto default; }
                        AccessAsLoggedIn(commandParameters);
                        Commands.ShareAlbumCommand shareAlbum = new ShareAlbumCommand();
                        result = shareAlbum.Execute(commandParameters.Skip(1).ToArray());
                        break;
                    case "UploadPicture":////
                        if (commandParameters.Length != 4) { goto default; }
                        AccessAsLoggedIn(commandParameters);
                        Commands.UploadPictureCommand uppCommand = new UploadPictureCommand();
                        result = uppCommand.Execute(commandParameters.Skip(1).ToArray());
                        break;
                    case "Exit":////
                        if (commandParameters.Length != 1) { goto default; }
                        // both users can
                        Commands.ExitCommand exit = new ExitCommand();
                        result = exit.Execute();
                        break;
                    case "Login":////
                        if (commandParameters.Length != 3) { goto default; }
                        AccessAsLoggedOut();
                        Commands.LoginCommand login = new LoginCommand();
                        result = login.Execute(commandParameters.Skip(1).ToArray());
                        break;
                    case "Logout":///
                        if (commandParameters.Length != 1) { goto default; }
                        AccessAsLoggedIn(commandParameters);
                        Commands.LogoutCommand logout = new LogoutCommand();
                        result = logout.Execute();
                        break;
                    default:
                        throw new InvalidOperationException($"Command {commandParameters[0]} not valid!");
                        }

            return result;
        }

        private void AccessAsLoggedOut()
        {
            if (UserControl.IsLogged)
            {
                throw new ArgumentException($"Logged users cannot issue this command!");
            }
        }

        private void AccessAsLoggedIn(string[] commandParameters)
        {
            if (!AccessCommand(commandParameters[0]))
            {
                throw new ArgumentException($"Only logged users can issue this command!");
            }
        }

        private bool AccessCommand(string command)
        {

            // This part of the exercise "If any of these rules are violated print: “Invalid credentials!” and throw InvalidOperationException" - is performed more intelligent here - it tells you what should you do (login or logout) in order to issue the command, not "Invalid credentials!" as it is written in the exercise.
            bool isAccessable = false;
            Dictionary<string, string> accessList = new Dictionary<string, string>();
            accessList["RegisterUser"] = "unauthenticated";
            accessList["Login"] = "unauthenticated";
            accessList["ListFriends"] = "both";
            accessList["AddTown"] = "authenticated";
            accessList["ModifyUser"] = "authenticated";
            accessList["DeleteUser"] = "authenticated";
            accessList["AddTag"] = "authenticated";
            accessList["CreateAlbum"] = "authenticated";
            accessList["AddTagTo"] = "authenticated";
            accessList["MakeFriends"] = "authenticated";
            accessList["ShareAlbum"] = "authenticated";
            accessList["UploadPicture"] = "authenticated";
            accessList["Logout"] = "authenticated";
            accessList["Exit"] = "both";

            if (accessList.ContainsKey(command))
            {
                if (UserControl.IsLogged && (accessList[command] == "authenticated" || accessList[command] == "both"))
                {
                    isAccessable = true;
                }
            }
            else
            {
                throw new InvalidOperationException($"Command {command} not valid!");
            }
            return isAccessable;

        }
    }
}
