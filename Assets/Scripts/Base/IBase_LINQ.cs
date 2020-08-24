using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBase_LINQ
{

    /// <summary>
    /// Инициализировать список для работы
    /// </summary>
    void InitializationMockups();

    /// <summary>
    /// Полная запись запроса
    /// </summary>
    void FullWriting();

    /// <summary>
    /// Запись через расширение
    /// </summary>
    void ExtensionWriting();

    /// <summary>
    /// Проверить все пути
    /// </summary>
    void CheckWays();

    /// <summary>
    /// Вывести в дебаг один способ
    /// </summary>
    void Show();
}
