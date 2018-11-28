namespace UnitTestProject1
{
    public class TestPage
    {
        [CustomFindBy(How = How.Id, Using = "Test Id")]
        public Button testButton;
    }
}
