using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Answer
{
    public int Id { get; set; }

    public string Content { get; set; } = null!;

    public int? QuestionId { get; set; }

    public bool? IsCorrect { get; set; }

    public virtual Question? Question { get; set; }

    public virtual ICollection<SelectedAnswer> SelectedAnswers { get; set; } = new List<SelectedAnswer>();
}
