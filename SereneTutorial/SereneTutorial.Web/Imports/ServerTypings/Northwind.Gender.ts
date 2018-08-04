namespace SereneTutorial.Northwind {
    export enum Gender {
        Male = 1,
        Female = 2
    }
    Serenity.Decorators.registerEnumType(Gender, 'SereneTutorial.Northwind.Gender', 'SereneTutorial.Northwind.Entities.Gender');
}
