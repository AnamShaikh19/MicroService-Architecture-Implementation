using Mango.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Coupon> Coupons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 1,
                CouponCode = "2fff",
                DiscountAmount = 10,
                MinAmount = 20,
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 2,
                CouponCode = "25ff",
                DiscountAmount = 10,
                MinAmount = 20,
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 3,
                CouponCode = "2gff",
                DiscountAmount = 10,
                MinAmount = 20,
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 4,
                CouponCode = "4fff",
                DiscountAmount = 10,
                MinAmount = 20,
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 6,
                CouponCode = "33gg",
                DiscountAmount = 10,
                MinAmount = 20,
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 7,
                CouponCode = "2fhff",
                DiscountAmount = 10,
                MinAmount = 20,
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 8,
                CouponCode = "2fkkf",
                DiscountAmount = 10,
                MinAmount = 20,
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 9,
                CouponCode = "k444",
                DiscountAmount = 10,
                MinAmount = 20,
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 10,
                CouponCode = "3ggg",
                DiscountAmount = 10,
                MinAmount = 20,
            });
        }
    }
    
}
