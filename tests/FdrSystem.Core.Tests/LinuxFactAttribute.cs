using Xunit;

namespace FdrSystem.Core.Tests;

/// <summary>
/// Fact que só corre em Linux. Os caminhos XDG não têm efeito no Windows,
/// por isso estes testes são ignorados fora do Linux e correm na CI Linux.
/// </summary>
public sealed class LinuxFactAttribute : FactAttribute
{
    public LinuxFactAttribute()
    {
        if (!OperatingSystem.IsLinux())
        {
            Skip = "Teste específico de Linux/XDG; corre na CI Linux.";
        }
    }
}
