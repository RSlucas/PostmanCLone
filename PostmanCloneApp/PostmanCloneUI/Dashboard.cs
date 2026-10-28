using PostmanCloneLib;

namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    private readonly IApiAcces api = new ApiAcces();

    public Dashboard()
    {
        InitializeComponent();
        httpVerbSelection.SelectedItem = "GET";
    }
    private void Dashboard_Load(object sender, EventArgs e)
    {
    }

    private async void CallAPI_Click(object sender, EventArgs e)
    {
        systemStatus.Text = "Calling API...";
        resultsText.Text = "";

        if (!api.IsValidUrl(Apitext.Text))
        {
            systemStatus.Text = "Invalid URL";
            return;
        }

        try
        {
            systemStatus.Text = "Calling API...";

            resultsText.Text = await api.CallApiAsync(Apitext.Text);
            callData.SelectedTab = outputTab;
            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultsText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }
    private void Apitext_TextChanged(object sender, EventArgs e)
    {
    }

    private void apiLabel_Click(object sender, EventArgs e)
    {

    }

    private void Apitext_TextChanged_1(object sender, EventArgs e)
    {
        
    }
}
