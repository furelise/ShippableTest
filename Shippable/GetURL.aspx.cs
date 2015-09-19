using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using Newtonsoft.Json;
namespace Shippable
{
    public partial class GetURL : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {


        }
        public static List<Class1> GetItems(string url)
        {
            
            WebClient w = new WebClient();
            w.Headers.Add("user-agent", "Only a test!");
            var json_data = string.Empty;
            // downloading JSON data as a string
            try
            {
                json_data = w.DownloadString(url);
            }
            catch (Exception) { }
                              
            return JsonConvert.DeserializeObject<List<Class1>>(json_data);

        }
        public string ModifyURL(string url)
        {
            /* This function will facilitate testing of URL in following formats:
            * https://github.com/Shippable/support
            * https://github.com/Shippable/support/
            * https://github.com/Shippable/support/issues
            * https://github.com/Shippable/support/issues/
            * All of above should give the same result.
             * 
             * Also this function will convert the given url to github api URL that is used to fetch JSON string
            */
           
            string part1 = url.Substring(19);          // From https://github.com/Shippable/support/issues I am extracting all characters after 19th character, i.e https://github.com/
            string part2 = "https://api.github.com/repos/" + part1; //appending that to the actual URL that we use to get JSOn string

           

            if (url.Substring(url.Length - 7) == "/issues")//if user hasn't entered '/issues'at end, this part of code will append it to the end
            {
            }
            else if (url.Substring(url.Length - 8) == "/issues/")   
            {

                part2 = part2.Substring(0, part2.Length - 1);
               
            }
            else{
                if (url.Substring(url.Length - 1) != "/")//if '/' is NOT given
                    part2 = part2 + "/issues";
                else
                    part2 = part2 + "issues"; //if '/' is given
            }
            return part2;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var url2 = urlText.Text;
            int open=0, open24=0,open247=0,open7=0; //Initialisation of variables
        
            var url = ModifyURL(url2); //converting URL to get Json string
            List<Class1> issues = GetItems(url); //getting list of issues

            try
            {
                foreach (Class1 rObj in issues) //iterate through the list of issues
                {


                    if (rObj.state == "open") //check if issue is open
                        open++;
                    DateTime created = rObj.created_at;
                    var hours = (DateTime.Now - created).TotalHours; //get total number if hours since the issue is created

                    if (hours < 24) //check if less than 24 hours
                    {
                        open24++;
                    }
                    if (hours > 24 && hours < (24 * 7)) //check if more than 24 hours but less that 7 days
                        open247++;
                    if (hours > (24 * 7)) //check if more than 7 days
                        open7++;

                }
                Label9.Visible = true;        //just a display message
                Label9.ForeColor = System.Drawing.Color.Green;
                results.Visible = true;
                Label9.Text = "Data retrieved successfully!";


                Label2.Text = Convert.ToString(open);//shows results
                Label4.Text = Convert.ToString(open24);
                Label6.Text = Convert.ToString(open247);
                Label8.Text = Convert.ToString(open7);
            }
            catch (Exception ex)
            {
                results.Visible = false; //incase the URL is not pointing to correct repo or 
                Label9.Visible = true;
                Label9.ForeColor = System.Drawing.Color.Red;
                Label9.Text = "Data could not be retrieved... due to invalid Github URL or connectivity issues.";
            }
            
        }
        
      
    }
}