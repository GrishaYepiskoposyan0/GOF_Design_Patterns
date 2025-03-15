namespace GoF_Design_Patterns.Creational.Singleton;

public class ConfigurationManager
{
    private static ConfigurationManager _instance;
    
    private ConfigurationManager(){}

    public static ConfigurationManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ConfigurationManager();
            }

            return _instance;
        }
    }

    public string GetConfiguration(string key)
    {
        return "Some configuration";
    }
}