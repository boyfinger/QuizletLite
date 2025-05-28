using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Quiz
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? CreatedBy { get; set; }

    public short? Status { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<Question> Questions { get; set; } = new List<Question>();

    public virtual ICollection<QuizResult> QuizResults { get; set; } = new List<QuizResult>();
}
