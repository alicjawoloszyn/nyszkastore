using System;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "nieprawidłowe zapytanko",
                401 => "a może jakieś uwierzytelnianko?",
                404 => "nie znalazłem :(",
                500 => "niespodziewany błąd serwera",
                _ => null
            };
        }
    }
}