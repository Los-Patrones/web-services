﻿using Microsoft.EntityFrameworkCore;
using WebApplication1.App.Domain.Models;
using WebApplication1.App.Domain.Repository;
using WebApplication1.App.Shared.Persistence.Contexts;

namespace WebApplication1.App.Persistence.Repositories;

public class PaymentMethodRepository:BaseRepository,IPaymentMethodRepository
{
    public PaymentMethodRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<PaymentMethod>> ListAsync()
    {
        return await _context.PaymentMethods.ToListAsync();
    }

    public async Task AddAsync(PaymentMethod paymentMethod)
    {
        await _context.PaymentMethods.AddAsync(paymentMethod);
    }

    public async Task<PaymentMethod> FindByIdAsync(int id)
    {
        return await _context.PaymentMethods.FindAsync(id);
    }

    public void Update(PaymentMethod paymentMethod)
    {
        _context.PaymentMethods.Update(paymentMethod);
    }

    public void Remove(PaymentMethod paymentMethod)
    {
        _context.PaymentMethods.Remove(paymentMethod);
    }
}