﻿namespace NeuralNetworkNamespace
{
    public interface ICostFunction
    {
        double Function(double expected, double actual);
        double Derivative(IActivationFunction activationFunction, double activationInput, double expected, double actual);

        // кароче меченый мозги хватит ебать я похоже нашел как оно должно быть
        // есть стохастический градиентный спуск это где у тебя 200 примеров и ты каждый пример обрабатываешь отдельно и далее меняешь в соответсвии с ошибкой 200 примеров
        // значит функция ошибки будет без суммы ∑ просто нахуй ее оттуда выкидывай
        // но производну все равно считать надо - и без суммы
        // есть пакетный градиентный спуск там все 200 примеров обрабатываются и считается средняя ошибка по всем и потом 1 раз меняется
        // вот там с суммами надо работать ∑
        //
        // тут я стохастический делаю
    }
}
