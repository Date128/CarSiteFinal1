using System;
using System.Collections.Generic;

namespace Domain.Models;

/// Модель рекомендации эксперта.
public partial class ExpertRecommendation
{
    /// Уникальный идентификатор рекомендации.
    public int RecommendationId { get; set; }

    /// Идентификатор эксперта (пользователя), который оставил рекомендацию.
    public int? ExpertId { get; set; }

    /// Идентификатор автомобиля, для которого оставлена рекомендация.
    public int? CarId { get; set; }

    /// Навигационное свойство для связи с автомобилем.
    public virtual Car? Car { get; set; }

    /// Навигационное свойство для связи с экспертом (пользователем).
    public virtual User? Expert { get; set; }

    /// Навигационное свойство для связи с постом, содержащим рекомендацию.
    public virtual Post Recommendation { get; set; } = null!;
}