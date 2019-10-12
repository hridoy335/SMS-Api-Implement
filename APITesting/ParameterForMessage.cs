namespace APITesting
{
    internal class ParameterForMessage
    {
        public object ApiUrl { get; set; }
        public object UserName { get; set; }
        public object Password { get; set; }
        public string Message { get; set; }
        public object CommaSeperatedReceivers { get; set; }
    }
}