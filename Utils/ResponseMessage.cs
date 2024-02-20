namespace GenesisEfectivo_BE.Utils
{
    public class ResponseMessage
    {
        public string Code { get; set; }
        public string Response { get; set; }
        public object data { get; set; } 

        public object? extra { get; set; }
    }
}

