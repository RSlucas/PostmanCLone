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
        systemStatus.BackColor = Color.Transparent;

        systemStatus.Text = "Calling API...";
        resultsText.Text = "";

        if (api.IsValidUrl(Apitext.Text) == false)
        {
            systemStatus.Text = "Invalid URL";
            systemStatus.BackColor = Color.Red;
            return;
        } 

        HttpAction action;
        if (Enum.TryParse(httpVerbSelection.SelectedItem!.ToString(), out action) == false)
        {
            systemStatus.Text = "Invalid HTTP Verb";
            return;
        }

        try
        {
            systemStatus.Text = "Calling API...";

            resultsText.Text = await api.CallApiAsync(Apitext.Text, bodyText.Text, action);
            callData.SelectedTab = outputTab;
            outputTab.Focus();
            systemStatus.Text = "Ready";
            systemStatus.BackColor = Color.Green;
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

    private void resultsText_TextChanged(object sender, EventArgs e)
    {

    }
}
