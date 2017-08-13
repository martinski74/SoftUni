using System;
using _05.Security_Door;


class Program
{
    static void Main(string[] args)
    {
        ScannerUI scannerUi = new ScannerUI();
        KeyCardCheck keyCardCheck = new KeyCardCheck(scannerUi);
        PinCodeCheck pinCodeCheck = new PinCodeCheck(scannerUi);
        SecurityManager manager = new SecurityManager(keyCardCheck, pinCodeCheck);
        manager.Check();
    }
}

