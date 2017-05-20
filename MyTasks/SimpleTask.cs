using System;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using System.IO;
using System.Text;
using System.Configuration;

namespace MyTasks
{
    public class SimpleTask : Task
    {
        private string _OutPutDir;

       
        public string OutPutDir
        {
            get { return _OutPutDir; }
            set { _OutPutDir = value; }
        }


        private string myProperty;

        [Required]
        public string MyProperty
        {
            get { return myProperty; }
            set { myProperty = value; }
        }
        public override bool Execute()
        {
            using(var w= new StreamWriter("Log.test", true, Encoding.UTF8))
            {
                w.WriteLine("ALL "+DateTime.Now);
                w.WriteLine("ll  "+AppDomain.CurrentDomain.BaseDirectory);
                var config = ConfigurationManager.AppSettings["NUGet"];
                w.WriteLine("bc " + _OutPutDir);
            }
            Log.LogMessage(MessageImportance.High, "messageResource3");
            return true;
        }
    }
}
