using SmartTeaching.Models;

namespace SmartTeaching.Services;
public static class TestService
{
    static List<TestItem> Tests{get;}

    static TestService()
    {
        Tests = new List<TestItem>
        {
            new TestItem{
                ExamQuestion="下列关于匀变速直线运动的说法正确的是(　　)",
                AnswerA="匀加速直线运动的速度一定与时间成正比",
                AnswerB="匀减速直线运动就是加速度为负值的运动",
                AnswerC="匀变速直线运动的速度随时间均匀变化",
                AnswerD="速度先减小再增大的运动一定不是匀变速直线运动",
                RightAnswer="A"
            }
        };
    }
    static int nextId = 3;
    public static List<TestItem> GetAll()=>Tests;
    public static TestItem? Get(int id)=>Tests.FirstOrDefault(p=>p.Id == id);
}