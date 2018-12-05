﻿using System.Collections.Generic;
using System.Windows.Controls;

namespace Klipper.Desktop.WPF.Views.WorkTime
{
    /// <summary>
    /// Interaction logic for LeaveEmployeesList.xaml
    /// </summary>
    public partial class LeaveEmployeesList : UserControl
    {
        public List<LeaveEmployeeList> items { get; set; }
        public LeaveEmployeesList()
        {
            InitializeComponent();
            items = new List<LeaveEmployeeList>();
            items.Add(new LeaveEmployeeList() { Name = "Naushad", AppliedDate = 24, Days = "4", Duration = "warsinak@gmail.com", Type = "Sick", Emp_Comment = "abc", Status = "pending", Your_Comment = "xyz" });
            items.Add(new LeaveEmployeeList() { Name = "Naushad", AppliedDate = 24, Days = "4", Duration = "warsinak@gmail.com", Type = "Sick", Emp_Comment = "abc", Status = "pending", Your_Comment = "xyz" });
            items.Add(new LeaveEmployeeList() { Name = "Naushad", AppliedDate = 24, Days = "4", Duration = "warsinak@gmail.com", Type = "Sick", Emp_Comment = "abc", Status = "pending", Your_Comment = "xyz" });
            items.Add(new LeaveEmployeeList() { Name = "Naushad", AppliedDate = 24, Days = "4", Duration = "warsinak@gmail.com", Type = "Sick", Emp_Comment = "abc", Status = "pending", Your_Comment = "xyz" });
            items.Add(new LeaveEmployeeList() { Name = "Naushad", AppliedDate = 24, Days = "4", Duration = "warsinak@gmail.com", Type = "Sick", Emp_Comment = "abc", Status = "pending", Your_Comment = "xyz" });
            items.Add(new LeaveEmployeeList() { Name = "Naushad", AppliedDate = 24, Days = "4", Duration = "warsinak@gmail.com", Type = "Sick", Emp_Comment = "abc", Status = "pending", Your_Comment = "xyz" });
            items.Add(new LeaveEmployeeList() { Name = "Naushad", AppliedDate = 24, Days = "4", Duration = "warsinak@gmail.com", Type = "Sick", Emp_Comment = "abc", Status = "pending", Your_Comment = "xyz" });
            items.Add(new LeaveEmployeeList() { Name = "Naushad", AppliedDate = 24, Days = "4", Duration = "warsinak@gmail.com", Type = "Sick", Emp_Comment = "abc", Status = "pending", Your_Comment = "xyz" });
            items.Add(new LeaveEmployeeList() { Name = "Naushad", AppliedDate = 24, Days = "4", Duration = "warsinak@gmail.com", Type = "Sick", Emp_Comment = "abc", Status = "pending", Your_Comment = "xyz" });
            items.Add(new LeaveEmployeeList() { Name = "Naushad", AppliedDate = 24, Days = "4", Duration = "warsinak@gmail.com", Type = "Sick", Emp_Comment = "abc", Status = "pending", Your_Comment = "xyz" });
            ListView1.DataContext = items;
        }
    }
    public class LeaveEmployeeList
    {
        public string Name { get; set; }
        public int AppliedDate { get; set; }
        public string Duration { get; set; }
        public string Type { get; set; }
        public string Days { get; set; }
        public string Emp_Comment { get; set; }
        public string Status { get; set; }
        public string Your_Comment { get; set; }

    }
}
