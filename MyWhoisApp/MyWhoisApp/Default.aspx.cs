using ArinWhois.Client;
using System;
using System.Web.UI;
using Whois.NET;
using Whois;


namespace MyWhoisApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            string ipaddress;
            
            ipaddress = txtaddress.Text;

            //var arinClient = new ArinClient();

            //var result = WhoisClient.Query("69.63.176.0");

            // Check single IP
            //var response = arinClient.QueryIpAsync(IPAddress.Parse(ipaddress)).Result;

            

            //looks up the domain, works
            var whois = new WhoisLookup().Lookup(ipaddress);
            
            
            //arinClient.QueryIpAsync(System.Net.IPAddress.Parse(ipaddress));

            

            // Check single IP
            //var ipResponse = arinClient.QueryIpAsync(IPAddress.Parse(ipaddress)).Result;


            // Find out more about organization
            //var orgResponse = arinClient.QueryResourceAsync(ipResponse.Network.OrgRef.Handle,
                                        //ArinClient.ResourceType.Organization);


  
            panelresult.Visible = true;

            txtresults.Text = whois.ToString();

            //txtresults.Text = ipResponse.Network.Name.ToString();



            //txtresults.Text = String.Format("{0}, {1}", result.OrganizationName, result.AddressRange);
            //txtresults.Text = arinClient.ToString();
         
            
        }
    }
}