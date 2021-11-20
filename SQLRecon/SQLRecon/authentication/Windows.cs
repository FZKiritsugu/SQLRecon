﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SQLRecon.Auth;

namespace SQLRecon.Auth
{
    public class WindowsAuth
    {
        // this handles Windows authentication to MS SQL databases
        public SqlConnection Send(String sqlServer, String database)
        {
            //Console.WriteLine("[+] Windows Authentication Selected");
            string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            String conString = "Server = " + sqlServer + "; Database = " + database + "; Integrated Security = True;";
            TestAuthentication TestAuthentication = new TestAuthentication();
            return TestAuthentication.Send(conString, user, sqlServer);
        } // end Send
    }
}