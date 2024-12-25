using System;
using System.Collections.Generic;

namespace Domain.Models;

/// Модель записи о техническом обслуживании автомобиля.
public partial class TechnicalMaintenance
{
    /// Уникальный идентификатор записи о техническом обслуживании.
    public int MaintenanceId { get; set; }

    /// Идентификатор автомобиля, связанного с техническим обслуживанием.
    public int? CarId { get; set; }

    /// Идентификатор сервисного центра, где проводилось техническое обслуживание.
    public int? ServiceCenterId { get; set; }

    /// Дата проведения технического обслуживания.
    public DateTime MaintenanceDate { get; set; }

    /// Описание проведенного технического обслуживания.
    public string Description { get; set; } = null!;

    /// Стоимость технического обслуживания.
    public decimal Cost { get; set; }

    /// Навигационное свойство для связи с автомобилем.
    public virtual Car? Car { get; set; }

    /// Навигационное свойство для связи с сервисным центром.
    public virtual ServiceCenter? ServiceCenter { get; set; }
}