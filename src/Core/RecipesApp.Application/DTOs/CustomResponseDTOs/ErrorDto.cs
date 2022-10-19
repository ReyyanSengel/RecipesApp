using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.Application.DTOs.ResponseDTOs
{
    public class ErrorDto
    {
        public List<String> Errors { get; set; }
        public bool IsShow { get; set; }

        public ErrorDto()
        {
            Errors = new List<String>();
        }

        public ErrorDto(string errors, bool ısShow)
        {
            Errors.Add(errors);
            IsShow = true;
        }

        public ErrorDto(List<string> errors, bool ısShow)
        {
            Errors = errors;
            IsShow = ısShow;
        }
    }
}
