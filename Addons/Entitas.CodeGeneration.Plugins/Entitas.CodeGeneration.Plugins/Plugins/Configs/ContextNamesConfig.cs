﻿using System.Collections.Generic;
using Entitas.Utils;

namespace Entitas.CodeGeneration.Plugins {

    public class ContextNamesConfig : AbstractConfigurableConfig {

        const string CONTEXTS_KEY = "Entitas.CodeGeneration.Plugins.Contexts";

        public override Dictionary<string, string> defaultProperties {
            get {
                return new Dictionary<string, string> {
                    { CONTEXTS_KEY, "Game, GameState, Input" }
                };
            }
        }

        public string[] contextNames {
            get { return properties[CONTEXTS_KEY].ArrayFromCSV(); }
        }
    }
}
