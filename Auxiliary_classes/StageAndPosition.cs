﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Construction.Auxiliary_classes
{
    public class StageAndPosition
    {
        public string Stage { get; set; }
        public List<string> Position { get; set; }

        public override string ToString()
        {
            return Stage;
        }
        public static int GetIndexStage(string Stage)
        {
            switch (Stage)
            {
                case "Архітектування":
                    return 0;
                    break;
                case "Фундамент":
                    return 1;
                    break;
                case "Будівництво":
                    return 2;
                    break;
                case "Покрівля":
                    return 3;
                    break;
                case "Обробка":
                    return 4;
                    break;
                default: return -1;
            }

        }
        public static List<StageAndPosition> GetCategories()
        {
            return new List<StageAndPosition>
            {
                new StageAndPosition
                {
                    Stage = "Архітектування",
                    Position = new List<string>
                    {
                        "Архітектор"
                    }
                },
                new StageAndPosition
                {
                    Stage = "Фундамент",
                    Position = new List<string>
                    {
                        "Монолідчик",
                        "Помічник"
                    }
                },
                new StageAndPosition
                {
                    Stage = "Будівництво",
                    Position = new List<string>
                    {
                        "Муляр",
                        "Підсобник"
                    }
                },
                new StageAndPosition
                {
                    Stage = "Покрівля",
                    Position = new List<string>
                    {
                        "Тесляр",
                        "Покрівельник",
                        "Помічник"
                    }
                },
                new StageAndPosition
                {
                    Stage = "Обробка",
                    Position = new List<string>
                    {
                        "Штукатур",
                        "Маляр",
                        "Столяр",
                        "Помічник"
                    }
                }
            };
        }
        public static List<StageAndPosition> Get4Categories()
        {
            return new List<StageAndPosition>
            {
                new StageAndPosition
                {
                    Stage = "Фундамент",
                    Position = new List<string>
                    {
                        "Монолідчик",
                        "Помічник"
                    }
                },
                new StageAndPosition
                {
                    Stage = "Будівництво",
                    Position = new List<string>
                    {
                        "Муляр",
                        "Підсобник"
                    }
                },
                new StageAndPosition
                {
                    Stage = "Покрівля",
                    Position = new List<string>
                    {
                        "Тесляр",
                        "Покрівельник",
                        "Помічник"
                    }
                },
                new StageAndPosition
                {
                    Stage = "Обробка",
                    Position = new List<string>
                    {
                        "Штукатур",
                        "Маляр",
                        "Столяр",
                        "Помічник"
                    }
                }
            };
        }
    }
}
