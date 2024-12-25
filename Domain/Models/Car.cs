using System;
using System.Collections.Generic;

namespace Domain.Models;

/// Модель автомобиля.
public partial class Car
{
    /// Уникальный идентификатор автомобиля.
    public int CarId { get; set; }

    /// Марка автомобиля.
    public string Make { get; set; } = null!;

    /// Модель автомобиля.
    public string Model { get; set; } = null!;

    /// Год выпуска автомобиля.
    public int Year { get; set; }

    /// Цена автомобиля.
    public decimal Price { get; set; }

    /// Пробег автомобиля.
    public int Mileage { get; set; }

    /// Цвет автомобиля.
    public string Color { get; set; } = null!;

    /// Тип двигателя автомобиля.
    public string EngineType { get; set; } = null!;

    /// Тип трансмиссии автомобиля.
    public string Transmission { get; set; } = null!;

    /// Тип топлива автомобиля.
    public string FuelType { get; set; } = null!;

    /// Тип кузова автомобиля.
    public string BodyType { get; set; } = null!;

    /// Ссылка на изображение автомобиля.
    public string? ImageUrl { get; set; }

    /// Место продажи автомобиля.
    public string? SaleLocation { get; set; }

    /// Коллекция атрибутов автомобиля.
    public virtual ICollection<CarAttribute> CarAttributes { get; set; } = new List<CarAttribute>();

    /// Коллекция изображений автомобиля.
    public virtual ICollection<CarImage> CarImages { get; set; } = new List<CarImage>();

    /// Коллекция записей об аренде автомобиля.
    public virtual ICollection<CarRental> CarRentals { get; set; } = new List<CarRental>();

    /// Коллекция записей о продажах автомобиля.
    public virtual ICollection<CarSale> CarSales { get; set; } = new List<CarSale>();

    /// Коллекция рекомендаций экспертов для автомобиля.
    public virtual ICollection<ExpertRecommendation> ExpertRecommendations { get; set; } = new List<ExpertRecommendation>();

    /// Коллекция записей о техническом обслуживании автомобиля.
    public virtual ICollection<MaintenanceRecord> MaintenanceRecords { get; set; } = new List<MaintenanceRecord>();

    /// Коллекция постов, связанных с автомобилем.
    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

    /// Коллекция отзывов об автомобиле.
    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    /// Коллекция записей о техническом обслуживании автомобиля.
    public virtual ICollection<TechnicalMaintenance> TechnicalMaintenances { get; set; } = new List<TechnicalMaintenance>();

    /// Коллекция записей о тест-драйвах автомобиля.
    public virtual ICollection<TestDrife> TestDrives { get; set; } = new List<TestDrife>();
}