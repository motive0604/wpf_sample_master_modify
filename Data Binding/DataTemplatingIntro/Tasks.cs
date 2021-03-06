// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.ObjectModel;

namespace DataTemplatingIntro
{
    public class Tasks : ObservableCollection<Task>
    {
        public Tasks()
        {
            Add(new Task("Groceries1", "Pick up Groceries and Detergent", 2, TaskType.Home));
            Add(new Task("Laundry2", "Do my Laundry", 2, TaskType.Home));
            Add(new Task("Emaildd", "Email clients", 1, TaskType.Work));
            Add(new Task("Cleand", "Clean my office", 3, TaskType.Work));
            Add(new Task("Dinner", "Get ready for family reunion", 1, TaskType.Home));
            Add(new Task("Proposals", "Review new budget proposals", 2, TaskType.Work));
            Add(new Task("PDK", "Do my Laundry", 1, TaskType.Work));
        }
    }
}