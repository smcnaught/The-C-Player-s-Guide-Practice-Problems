(FoodTypes, MainIngredients, Seasonings)[] meals = new (FoodTypes, MainIngredients, Seasonings)[3];

for (int i = 0; i < 3; i++) {
  Console.WriteLine($"Would you like {FoodTypes.Gumbo}, {FoodTypes.Soup}, or {FoodTypes.Stew}?");
  Enum.TryParse(Console.ReadLine(), out FoodTypes userFoodType);

  Console.WriteLine($"Would you like {MainIngredients.Mushrooms}, {MainIngredients.Chicken}, {MainIngredients.Carrots}, or {MainIngredients.Potatoes}?");
  Enum.TryParse(Console.ReadLine(), out MainIngredients userMainIngredient);

  Console.WriteLine($"Would you like {Seasonings.Spicy}, {Seasonings.Salty}, or {Seasonings.Sweet}?");
  Enum.TryParse(Console.ReadLine(), out Seasonings userSeasoning);

  (FoodTypes FoodType, MainIngredients MainIng, Seasonings Seasoning) userMeal = (userFoodType, userMainIngredient, userSeasoning);
  meals[i] = userMeal;
}

foreach((FoodTypes, MainIngredients, Seasonings) meal in meals) {
  Console.WriteLine($"{meal.Item3} {meal.Item2} {meal.Item1}");
}