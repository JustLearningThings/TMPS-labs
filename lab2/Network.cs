public class Network
{
    public string name = "Network 1";
    public string company = "N/A";
    private bool connected = false;

    public void initializeNetwork(string netName, string netCompany)
    {
        name = netName;
        company = netCompany;
    }

    public void connect() { connected = true; }
    public void disconnect() { connected = false; }
    public bool getStatus() => connected;
}