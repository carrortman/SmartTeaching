using System.ComponentModel.DataAnnotations;

namespace SmartTeaching.Models;

public class TestItem{
    public int Id{get;set;}

    [Required]
    public string? ExamQuestion{get;set;} 
    public string? AnswerA{get;set;}
    public string? AnswerB{get;set;}
    public string? AnswerC{get;set;}
    public string? AnswerD{get;set;}
    public string? RightAnswer{get;set;}
    public int KnowledgeCardId{get;set;}
}