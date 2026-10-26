namespace PostmanCloneUI;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }
    private void Dashboard_Load(object sender, EventArgs e)
    {
    }

    private async void CallAPI_Click(object sender, EventArgs e)
    {


        try
        {
            systemStatus.Text = "Calling API...";

            await Task.Delay(2000);

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
