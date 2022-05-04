using EnergyCalculator.Calculations;
using EnergyCalculator.Types;

namespace EnergyCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddAppliance_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtApplianceName.Text) && txtApplianceWatts.Value != (decimal)0.0)
            {
                var appliance = new Appliance
                {
                    Id = Guid.NewGuid(),
                    Name = txtApplianceName.Text,
                    StandbyWatts = txtApplianceWatts.Value,
                    UsageWatts = txtApplianceUsageWatts.Value,
                };

                lstAppliances.Items.Add(appliance); 
            }
        }

        private void lstAppliances_SelectedIndexChanged(object sender, EventArgs e)
        {
            var appliances = lstAppliances.Items;
            var appliance = (Appliance)appliances[lstAppliances.SelectedIndex];

            if(appliance != null)
            {
                var costPerDay = CalculationService.CalculateDailyCost(appliance.StandbyWatts, (decimal)0.27);
                PopulateEnergyFields(costPerDay);
            }
        }

        private void PopulateEnergyFields(decimal costPerDay)
        {
            var roundedDailyCost = Math.Round(costPerDay, 2);

            var weeklyCost = costPerDay * 7;
            var roundedWeeklyCost = Math.Round(weeklyCost, 2);

            var monthlyCost = weeklyCost * 4;
            var roundedMonthlyCost = Math.Round(monthlyCost, 2);

            var yearlyCost = costPerDay * 365;
            var roundedYearlyCost = Math.Round(yearlyCost, 2);

            txtDailyCost.Text = costPerDay.ToString();
            txtRoundedDailyCost.Text = roundedDailyCost.ToString();

            txtWeeklyCost.Text = weeklyCost.ToString();
            txtRoundedWeeklyCost.Text = roundedWeeklyCost.ToString();

            txtMonthlyCost.Text = monthlyCost.ToString();
            txtRoundedMonthlyCost.Text = roundedMonthlyCost.ToString();

            txtYearlyCost.Text = yearlyCost.ToString(); 
            txtRoundedYearlyCost.Text = roundedYearlyCost.ToString();
        }
    }
}