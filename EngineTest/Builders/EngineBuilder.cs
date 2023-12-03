﻿using EngineTest.Engines;
using EngineTest.Exceptions;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineTest.Builders
{
    internal class EngineBuilder
    {
        private EngineProperties _engineProperties;

        /// <summary>
        /// Создаёт двигатель внутреннего сгорания на основе полученных свойств, а так же проверяет их корректность.
        /// </summary>
        public InternalCombustionEngine BuildICEngine(EngineProperties properties)
        {
            _engineProperties = properties;

            TestProperties();

            return new InternalCombustionEngine(properties);
        }
        /// <summary>
        /// Проверяет, корректно ли введены параметры создаваемого двигателя и возвращает true, если проверка была пройдена успешно.
        /// </summary>
        private bool TestProperties()
        {
            if ((_engineProperties.V.Length != _engineProperties.M.Length)
                || _engineProperties.M.Any(value => value < 0)
                || _engineProperties.V.Any(value => value < 0)
                || _engineProperties.M == null)
            {
                throw new InvalidLinearPiecewiseFunctionException("Некорректный ввод линейно-кусочной функции");
            }

            if(_engineProperties.I <= 0)
            {
                throw new InvalidInertiaMomentException("Некорректный ввод момента инерции");
            }

            if(_engineProperties.C < 0)
            {
                throw new InvalidCoolingSpeedException("Некорректный ввод коэффициента скорости охлаждения");
            }
            if(_engineProperties.Hm < 0)
            {
                throw new InvalidHmException("Некорректный ввод коэффициента зависимости скорости нагрева от крутящего момент");
            }
            if(_engineProperties.Hv < 0)
            {
                throw new InvalidHvException("Некорректный ввод коэффициента зависимости скорости нагрева от скорости вращения коленвала");
            }

            return true;
        }
    }
}
