﻿using System;
using System.Collections.Generic;

namespace techMADT.Models;

public partial class Cart
{
    public int CartId { get; set; }

    public int UsId { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual User Us { get; set; } = null!;
}
