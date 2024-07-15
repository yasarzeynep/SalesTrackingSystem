﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Domain.Dtos;

public sealed record RecipeDetailDto(
    Guid ProductId,
    decimal Quantity);