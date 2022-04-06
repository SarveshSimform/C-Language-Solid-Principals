using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.Liskov_Substitution_Principle
{
    class Demo
    {
        /// <summary>
        /// abstract class declared
        /// </summary>
        public abstract class ReadParameters
        {
            public abstract string GetDbConnString();

            public string ParseServerDetails(string DbConn)
            {
                return DbConn + " - Parsed";
            }
        }
        //inherited abstraction
        public class ReadParametersFromXML : ReadParameters
        {
            //override abstract method
            public override string GetDbConnString()
            {
                string dbConn = "Connection String From XML File";

                //Read XML file to get Connection String

                dbConn = ParseServerDetails(dbConn);

                return dbConn;
            }
        }

        public class ReadParametersFromJSON : ReadParameters
        {
            //override abstract method
            public override string GetDbConnString()
            {
                string dbConn = "Connection String From JSON File";

                //Read XML file to get Connection String

                dbConn = ParseServerDetails(dbConn);

                return dbConn;
            }
        }
    }
}
