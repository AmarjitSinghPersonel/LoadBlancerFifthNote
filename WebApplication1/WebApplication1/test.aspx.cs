using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class test : System.Web.UI.Page
    {
        bool taskAssigned = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public class clsAsignedTask
        {
            public int user { get; set; }
            public double tasks { get; set; }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int usr = Convert.ToInt32(txtUsers.Text);
            double task = Convert.ToDouble(txtTask.Text);
            List<clsAsignedTask> lstOutput = new List<clsAsignedTask>();
            lstOutput.Add(new clsAsignedTask { user = 1, tasks = 4 });
            lstOutput.Add(new clsAsignedTask { user = 2, tasks = 5 });
            lstOutput.Add(new clsAsignedTask { user = 3, tasks = 1 });
            var totaltsk = 10;
            taskAssigned = true;
            if (!taskAssigned)
            {
                var tskAss = task / usr;
                lblOutput.Text = "Tasks Assigend per user=" + Convert.ToString(tskAss);
                taskAssigned = true;

                for (int i = 0; i <= usr; i++)
                {
                    lstOutput.Add(new clsAsignedTask { user = i, tasks = tskAss });
                }
            }
            else
            {
                var totaltask = totaltsk + task;
                var tskAss = Math.Round(totaltask / usr);
                int j = 1;
                foreach (var itm in lstOutput)
                {
                    if (itm.tasks > tskAss)
                    {
                        var newTask = itm.tasks - tskAss;
                        lstOutput.Where(a => a.user == j).FirstOrDefault().tasks = Math.Round(itm.tasks - newTask);
                    }
                    else if (itm.tasks < tskAss)
                    {
                        var newTask = tskAss - itm.tasks;
                        lstOutput.Where(a => a.user == j).FirstOrDefault().tasks = Math.Round(itm.tasks + newTask);
                    }
                    else
                    {

                    }
                    j++;
                }
                lblOutput.Text = "Tasks Assigend per user=" + Convert.ToString(lstOutput[0].tasks);

            }
        }
    }
}