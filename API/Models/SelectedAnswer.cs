﻿using System;
using System.Collections.Generic;

namespace API.Models;

public partial class SelectedAnswer
{
    public int Id { get; set; }

    public int? QuizResultId { get; set; }

    public int? QuestionId { get; set; }

    public int? AnswerId { get; set; }

    public virtual Answer? Answer { get; set; }

    public virtual Question? Question { get; set; }

    public virtual QuizResult? QuizResult { get; set; }
}
