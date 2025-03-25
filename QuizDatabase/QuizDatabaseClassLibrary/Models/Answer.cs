using System;
using System.Collections.Generic;

namespace QuizDatabaseClassLibrary.Models;

public partial class Answer
{
    public int Id { get; set; }

    public string AnswerOne { get; set; } = null!;

    public string AnswerTwo { get; set; } = null!;

    public string AnswerThree { get; set; } = null!;

    public string AnswerFour { get; set; } = null!;

    public string CorrectAnswer { get; set; } = null!;

    public string QuestionContent { get; set; } = null!;
}
