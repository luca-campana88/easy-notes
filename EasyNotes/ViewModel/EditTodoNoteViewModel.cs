﻿using EasyNotes.Data.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyNotes.ViewModel
{
    public class EditTodoNoteViewModel : BaseViewModel
    {
        public TodoNote TodoNote { get; set; }

        public EditTodoNoteViewModel(TodoNote todoNote)
        {
            this.TodoNote = todoNote;
        }
    }
}