﻿using PatternKursProject.devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternKursProject
{
    /// <summary>
    /// перечисоение типо источника выбросов
    /// </summary>
   public enum SourceType
    {
        AIR,
        WATER,
        SOIL
    }
    /// <summary>
    /// класс системы анализа, установленной на источнике
    /// </summary>
    public class AnalysisSystem
    {
        /// <summary>
        /// учетный номер системы
        /// </summary>
        private int accountNumber;
        public int getAccountNumber() { return accountNumber; }

        /// <summary>
        /// тип источника выбросов
        /// </summary>
        private SourceType typeOfSystem;
        public SourceType getTypeOfSystem() { return typeOfSystem; }

        /// <summary>
        /// конструктор
        /// </summary>
        /// <param name="number"></param>
        /// <param name="type"></param>
        public AnalysisSystem(int number, SourceType type)
        {
            listDevices = new List<MeasuringDevice>();
            accountNumber = number;
            typeOfSystem = type;
        }
        /// <summary>
        /// список измерительных устройств, установленных на наблюдаемом этой системой источнике
        /// </summary>
        public List<MeasuringDevice> listDevices;

        /// <summary>
        /// добавление измерительного устройства
        /// </summary>
        /// <param name="dev"></param>
        public void addDevice(MeasuringDevice dev)
        {
            listDevices.Add(dev);
        }

        /// <summary>
        /// список последних измерений
        /// </summary>
        public List<Measurement> listLastMeasur;
        /// <summary>
        /// опросить приборы
        /// </summary>
        /// <returns></returns>
        public List<Measurement> getMeasurements()
             {
            listLastMeasur = new List<Measurement>();
            if (listDevices.Count != 0)
            { foreach (var device in listDevices)
                    listLastMeasur.Add(device.getMeasurement());
            }
            return listLastMeasur;
        }
        /// <summary>
        /// получить последние измерения
        /// </summary>
        /// <returns></returns>
        public List<Measurement> getLastMeasurements() {
                return listLastMeasur;
        }
    }
}
