﻿using System;

namespace TicTacToe.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public DateTime? EmailConfirmationDate { get; set; }
        public int Score { get; set; }
    }
}
