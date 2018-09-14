public static class FileStrings
{
    #region Fields&Properties

    public const string ConfigFileName = "Config.cfg";
    public const string StartConfig = "1kDBTNRH1NZ/jGJm2ep6TeEkhkc7bv+7imPoO3gdLswio6QpBFmLpUDQH4WWeqfT98qHXVgiEExqqk3ICZvo/BaRnAF0M36C7LfW10i5JAHn3JltlPxI43nCPQdl4XJq/vpMeHHTiZk1Ty/mIRSaZZfoxSFY4LywTftZzJ78VccLFAi+jNNkKWVOLJ3Gq06FgoNoi26bXOlxgleJRnVkHA==";

    #endregion
}

public static class UserStrings
{
    #region Fields&Properties

    //fields
    public const string NoGroup = "Не состоит в группе";
    public const string UserId = "UserId";
    public const string FIO = "FIO";
    public const string Login = "Login";
    public const string Password = "Password";
    public const string RememberMe = "RememberMe";

    //stored procedures
    public const string UserAuthorization = "spUserAuthorization";
    public const string RegisterUser = "spRegisterUser";

    //info messages
    public const string IncorrectLoginPass = "Такой комбинации логин/пароль несуществует!";
    public const string PasswordsNotMatch = "Пароли не совпадают!";
    public const string ExistingUser = "Пользователь с таким логином уже существует!";
    public const string SuccessfulRegistration = "Регистрация прошла успешно!";
    public const string IncorrectImage = "Аватар должен быть квадратных размеров (высота = ширине)!";

    #endregion
}

public static class GroupStrings
{
    #region Fields&Properties

    //fields
    public const string Name = "Name";

    //stored procedures
    public const string CreateGroup = "spCreateGroup";

    //info messages
    public const string IncorrectName = "Группа с таким названием уже существует!";
    public const string SuccessfullCreation = "Группа создана успешно!";
    public const string SuccessfullUserAdded = "Пользователя успешно добавлено в группу!";

    #endregion
}

public static class MessageBoxStrings
{
    #region Fields&Properties

    public const string Error = "Ошибка";
    public const string Success = "Успех";

    #endregion
}

public static class ActionStrings
{
    #region Fields&Properties

    //stored procedures
    public const string ActionList = "spGetActionList";

    //info messages
    public const string ActionCreted = "Действие добавлено успешно!";

    #endregion
}

public static class ProcedureResultStrings
{
    #region Fields&Properties

    public const string Success200 = "200";

    public const string Error101 = "101";

    #endregion
}