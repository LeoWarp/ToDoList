using System.ComponentModel.DataAnnotations;

namespace ToDoList.Domain.Enum;

public enum Priority
{
    [Display(Name = "Простая")]
    Easy = 1,
    [Display(Name = "Важная")]
    Medium = 2,
    [Display(Name = "Критичная")]
    Hard = 3
}