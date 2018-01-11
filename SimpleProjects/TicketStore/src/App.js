import React, {Component} from 'react';
import ReactDOM from 'react-dom';
import './App.css';



import NavigationBar from './Components/NavigationBar';
import Footer from './Components/Footer';

import $ from 'jquery';
import HomeView from './Views/HomeView';
import LoginView from './Views/LoginView';
import RegisterView from './Views/RegisterView';
import ListTicketsView from './Views/ListTicketsView';
import CreateTicketView from './Views/CreateTicketView';
import EditTicketView from './Views/EditTicketView';
import DeleteTicketView from './Views/DeleteTicketView';
import KinveyRequester from './KinveyRequest';

export default class App extends Component {
    constructor(props) {
        super(props);
        this.state = {
            username: sessionStorage.getItem("username"),
            userId: sessionStorage.getItem("userId")
        };
    }

    render() {
        return (
            <div className="App">
                <header>
                    <NavigationBar
                        username={this.state.username}
                        homeClicked={this.showHomeView.bind(this)}
                        loginClicked={this.showLoginView.bind(this)}
                        registerClicked={this.showRegisterView.bind(this)}
                        ticketsClicked={this.showTicketsView.bind(this)}
                        addTicketClicked={this.showCreateTicketView.bind(this)}
                        logoutClicked={this.logout.bind(this)}
                    />
                    <div id="loadingBox">Loading...</div>
                    <div id="infoBox">Info msg</div>
                    <div id="errorBox">Error msg</div>
                    <div className="App-header">

                    </div>
                </header>
                <div id="main">
                </div>
                <Footer/>
            </div>
        );
    }

    componentDidMount() {
        // Attach global AJAX "loading" event handlers
        $(document).on({
            ajaxStart: function () {
                $("#loadingBox").show()
            },
            ajaxStop: function () {
                $("#loadingBox").hide()
            }
        });
        // Attach a global AJAX error handler
        $(document).ajaxError(this.handleAjaxError.bind(this));
        this.showHomeView();
    }

    handleAjaxError(response) {
        let errorMsg = JSON.stringify(response);
        if (response.readyState === 0)
            errorMsg = "Cannot connect due to network error.";
        if (response.responseJSON && response.responseJSON.description)
            errorMsg = response.responseJSON.description;
        this.showError(errorMsg);
    }

    showInfo(message) {
        $('#infoBox').text(message).show();
        setTimeout(function () {
            $('#infoBox').fadeOut();
        }, 3000);
    }

    showError(errorMsg) {
        $('#errorBox').text("Error: " + errorMsg).show();
    }

    showView(reactViewComponent) {
        ReactDOM.render(reactViewComponent,
            document.getElementById('main'));
        $('#errorBox').hide();
    };

    showHomeView() {
        this.showView(<HomeView username={this.state.username}/>);
    }

    showLoginView() {
        this.showView(<LoginView onsubmit={this.login.bind(this)}/>);
    }

    login(username, password) {
        KinveyRequester.loginUser(username, password)
            .then(loginSuccess.bind(this));

        function loginSuccess(userInfo) {
            this.saveAuthInSession(userInfo);
            this.showTicketsView();
            this.showInfo("Login successful.");
        }
    }

    saveAuthInSession(userInfo) {
        sessionStorage.setItem('authToken', userInfo._kmd.authtoken);
        sessionStorage.setItem('userId', userInfo._id);
        sessionStorage.setItem('username', userInfo.username);

        // This will update the entire app UI (e.g. the navigation bar)
        this.setState({
            username: userInfo.username,
            userId: userInfo._id
        });
    }

    showRegisterView() {
        this.showView(<RegisterView onsubmit={this.register.bind(this)}/>);
    }

    register(username, password) {
        KinveyRequester.registerUser(username, password)
            .then(registerSuccess.bind(this));

        function registerSuccess(userInfo) {
            this.saveAuthInSession(userInfo);
            this.showTicketsView();
            this.showInfo("User registration successful.");
        }
    }

    showTicketsView() {
        KinveyRequester.loadTickets()
            .then(loadTicketsSuccess.bind(this));

        function loadTicketsSuccess(tickets) {
            this.showInfo("Tickets loaded.");
            this.showView(
                <ListTicketsView
                    tickets={tickets}
                    onedit={this.loadTicketForEdit.bind(this)}
                    ondelete={this.loadTicketForDelete.bind(this)}
                />);
        }
    }

    showCreateTicketView() {
        this.showView(<CreateTicketView onsubmit={this.createTicket.bind(this)}/>)
    }

    createTicket(title, event, date, mail, Quantity) {
        KinveyRequester.createTicket(title, event, date, mail, Quantity)
            .then(createTicketSuccess.bind(this));

        function createTicketSuccess() {
            this.showInfo("Tickets added.");
            this.showTicketsView();
        }
    }

    loadTicketForEdit(ticketId) {
        KinveyRequester.findTicketById(ticketId).then(findTicketSuccess.bind(this));

        function findTicketSuccess(ticket) {
            let editTicketView = <EditTicketView
                ticketId={ticket._id}
                title={ticket.title}
                event={ticket.event}
                date={ticket.date}
                mail={ticket.mail}
                Quantity={ticket.Quantity}
                onsubmit={this.editTicket.bind(this)}
            />;
            this.showView(editTicketView)
        }
    }

    editTicket(ticketId, title, event, date, mail, Quantity) {

        KinveyRequester.editTicket(ticketId, title, event, date, mail, Quantity).then(editTicketSuccess.bind(this));

        function editTicketSuccess() {
            this.showInfo("Tickets edited.");
            this.showTicketsView();
        }
    }

    loadTicketForDelete(ticketId) {
        KinveyRequester.findTicketById(ticketId)
            .then(loadTicketForDeleteSuccess.bind(this));

        function loadTicketForDeleteSuccess(ticket) {
            this.showView(
                <DeleteTicketView
                    ticketId={ticket._id}
                    title={ticket.title}
                    event={ticket.event}
                    date={ticket.date}
                    mail={ticket.mail}
                    Quantity={ticket.Quantity}
                    onsubmit={this.deleteTicket.bind(this)}
                />
            );
        }
    }

    deleteTicket(ticketId) {
        KinveyRequester.deleteTicket(ticketId)
            .then(deleteTicketSuccess.bind(this));

        function deleteTicketSuccess() {
            this.showTicketsView();
            this.showInfo("Ticket was deleted.");
        }
    }

    logout() {
        sessionStorage.clear();
        this.setState({
            username: null,
            userId: null
        });
        this.showInfo("You are logout");
        this.showHomeView();
    }


}

