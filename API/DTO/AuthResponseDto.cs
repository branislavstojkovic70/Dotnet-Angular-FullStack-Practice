namespace API.DTO
{
    public class AuthResponseDto
    {
        public string? Token { get; set; }
        public bool isSuccess { get; set; }
        public string Message { get; set; }
    }
}
