namespace ExceptionsTask.DTOs
{
    public record ErrorResultDTO
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
    }
}
