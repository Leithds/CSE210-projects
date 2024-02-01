using System;

class WritingAssignment : Assignment
{
    private string _title = "";
    public WritingAssignment()
    {
  
    }
    public string GetWritingInformation()
    {
        return _studentName + " " + _title;
    }
}