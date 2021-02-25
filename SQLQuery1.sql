SELECT FoodInTheFridge.Name, FoodType.TypeName FROM FoodType
JOIN FoodInTheFridge ON FoodInTheFridge.TypeId = FoodType.Id