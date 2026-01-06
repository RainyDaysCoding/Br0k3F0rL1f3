using Br0k3F0rL1f3.Shared.Services;

namespace Br0k3F0rL1f3.Web.Services;

public class FormFactor : IFormFactor
{
    public string GetFormFactor()
    {
        return "Web";
    }

    public string GetPlatform()
    {
        return Environment.OSVersion.ToString();
    }
}
