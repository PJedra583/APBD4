using LegacyApp;

namespace LegacyAppTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var userService = new UserService();

        var result = userService.AddUser(
            null,
            "Kowalski",
            "kowalski@kowal.com",
            DateTime.Now, 1);
        Assert.False(result);
    }
}