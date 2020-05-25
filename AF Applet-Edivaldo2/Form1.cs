using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Libraries
using OSIsoft.AF;
using OSIsoft.AF.Asset;
using OSIsoft.AF.Time;
using OSIsoft.AF.UnitsOfMeasure;
using OSIsoft.AF.Data;

// Notifications Libraries
using OSIsoft.AF.Notification;
using OSIsoft.AF.EventFrame;
using OSIsoft.AF.Search;


namespace AF_Applet_Edivaldo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Inicialise data archive picker
            afDatabasePicker1.SystemPicker = piSystemPicker1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void afDatabasePicker1_SelectionChange(object sender, OSIsoft.AF.UI.SelectionChangeEventArgs e)
        {   
            // connect to selected afdb
            AFDatabase db = afDatabasePicker1.AFDatabase;

            // clear the treeview
            afTreeView1.AFRoot = null;

            // Se algo tiver selecionado, exibir
            if (db!= null)
            {
                // get the treview elementes
                afTreeView1.AFRoot = db.Elements;
            }


        }

        private void afTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // get the af attributs
            AFElement SelectedElement = afTreeView1.AFSelection as AFElement;


            // Clear all listboxs            
            lbAttributes.Items.Clear();
            lbNotificationRules.Items.Clear();
            lbNotificationInstances.Items.Clear();

            if ( SelectedElement != null)
            {   
                // Add Attributes to lbattributes
                lbAttributes.Items.AddRange(SelectedElement.Attributes.ToArray<AFAttribute>());

                // Search for notification rules configured
                IList<AFNotificationRule> notificationRules = SelectedElement.NotificationRules;
                lbNotificationRules.Items.AddRange(notificationRules.ToArray());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetData(object sender, EventArgs e)
        {
            AFAttribute SelectedAttribute = lbAttributes.SelectedItem as AFAttribute;

            AFTime starTime = new AFTime(tbStart.Text);
            AFTime endTime = new AFTime(tbEnd.Text);
            AFTimeRange timeRange = new AFTimeRange(starTime, endTime);


            // get values from specified time range
            UOM desiredUOM = cbUOM.SelectedItem as UOM;



            // The desired consiulting mode
            AFValues values;

            switch(cbDataMethod.Text){
                case "Recorded Values":

                    values = SelectedAttribute.Data.RecordedValues(timeRange
                                            , AFBoundaryType.Interpolated
                                            , desiredUOM
                                            , null
                                            , true);

                    break;

                case "Interpolated Values":

                    values = SelectedAttribute.Data.InterpolatedValues(timeRange
                                            ,AFTimeSpan.Parse("5m")
                                            , desiredUOM
                                            , null
                                            , true);

                    break;

                case "Plot Values":
                    values = SelectedAttribute.Data.PlotValues(timeRange
                        ,300
                        , desiredUOM);
                    break;

                default:

                    values = new AFValues();
                    break;
            }

            //AFValues Values = SelectedAttribute.GetValues(timeRange, 0, desiredUOM);

            lbValues.Items.Clear();

            if (values != null)
            {
                foreach (AFValue value in values)
                {
                    String myStr = string.Format("{0} \t {1}, {2}"
                        , value.Timestamp.LocalTime
                        , value.Value
                        , value.UOM != null ? value.UOM.Abbreviation : null);

                    lbValues.Items.Add(myStr);

                }
            }


         }

        private void cbUOM_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void lbAttributes_SelectedIndexChanged(object sender, EventArgs e)
        {
            AFAttribute SelectedAttribute = lbAttributes.SelectedItem as AFAttribute;

            cbUOM.Items.Clear();
            cbUOM.Text = null;

            if (SelectedAttribute == null || SelectedAttribute.DefaultUOM == null) return;

            UOMClass SelectedUOMClass = SelectedAttribute.DefaultUOM.Class;

            cbUOM.Items.AddRange(SelectedUOMClass.UOMs.ToArray());

            cbUOM.SelectedItem = SelectedAttribute.DefaultUOM;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbNotificationRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Selected notification rule
            AFNotificationRule SelectedNotificationRule = lbNotificationRules.SelectedItem as AFNotificationRule;

            // Clear the notificaiton list
            lbNotificationInstances.Items.Clear();

            // Check empty Selected
            if (SelectedNotificationRule == null) return;

            // Get information from Notification Rule Selected;
            AFTime startTime = new AFTime(tbStart.Text);
            AFTime endTime = new AFTime(tbEnd.Text);
            AFElement targetElement = SelectedNotificationRule.Target;
            AFDatabase database = SelectedNotificationRule.Database;


            // Consulting the dataBase
            string query = string.Format("Element: '{0}' {1}", targetElement.GetPath(database), SelectedNotificationRule.Criteria);
            AFEventFrameSearch search = new AFEventFrameSearch(database, "", AFSearchMode.Overlapped, startTime,endTime, query);

            search.CacheTimeout = TimeSpan.FromMinutes(5);

            IEnumerable<AFEventFrame> instances = search.FindEventFrames(fullLoad: false);

            // Populate the eventframe listbox

            foreach(AFEventFrame instance in instances)
            {
                string s = string.Format("Element: {0}, \t{1}, \t{2}"
                    , targetElement.Name
                    , instance.StartTime.LocalTime
                    , instance.EndTime == AFTime.MaxValue ? "Event is ongoing": instance.EndTime.LocalTime.ToString());
                lbNotificationInstances.Items.Add(s);
            }

        }
    }
}
