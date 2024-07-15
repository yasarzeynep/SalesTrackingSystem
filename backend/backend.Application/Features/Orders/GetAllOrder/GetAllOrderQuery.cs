﻿using backend.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace backend.Application.Features.Orders.GetAllOrder;

public sealed record GetAllOrderQuery() : IRequest<Result<List<Order>>>;