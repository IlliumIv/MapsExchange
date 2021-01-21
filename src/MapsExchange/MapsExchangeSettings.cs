﻿using System.Collections.Generic;
using ExileCore.Shared.Attributes;
using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using SharpDX;

namespace MapsExchange
{
    public class MapsExchangeSettings : ISettings
    {
        public Dictionary<string, int> MapStashAmount = new Dictionary<string, int>();

        public MapsExchangeSettings()
        {
            BordersWidth = new RangeNode<int>(3, 1, 10);
            Spacing = new RangeNode<float>(1, 0, 10);
            ShowPenalty = new ToggleNode(true);
        }

        [Menu("Borders Width")]
        public RangeNode<int> BordersWidth { get; set; }
        [Menu("Spacing")]
        public RangeNode<float> Spacing { get; set; }
        [Menu("Show Penalty On Hover")]
        public ToggleNode ShowPenalty { get; set; }
        [Menu("Text Size")]
        public RangeNode<float> TextSize { get; set; } = new RangeNode<float>(30, 10, 100);
        [Menu("Show Amount")]
        public ToggleNode ShowAmount { get; set; } = new ToggleNode(true);
        [Menu("White Map Color")]
        public ColorNode WhiteMapColor { get; set; } = Color.White;
        [Menu("Yellow Map Color")]
        public ColorNode YellowMapColor { get; set; } = Color.Yellow;
        [Menu("Red Map Color")]
        public ColorNode RedMapColor { get; set; } = new Color(1, 0.3f, 0.3f, 1f);


        [Menu("", 1)]
        public EmptyNode _1 { get; set; }
        [Menu("Show OnAtlas", "Note: Press CTRL whe atlas opened to see map level end exp penalty", 1, 1)]
        public ToggleNode ShowOnAtlas { get; set; } = new ToggleNode(true);
        [Menu("Maps Tab (to check amount)", 2, 1)]
        public RangeNode<int> MapTabNode { get; set; } = new RangeNode<int>(0, 0, 100);
        [Menu("Show Buy Button", 3, 1)]
        public ToggleNode ShowBuyButton { get; set; } = new ToggleNode(true);

        [Menu("UnCompleted Map Settings", 2)]
        public EmptyNode _2 { get; set; }
        // [Menu("Show UnCompleted", 1, 2)]
        // public ToggleNode ShowUnCompleted { get; set; } = new ToggleNode(true);
        [Menu("Text Transparency", 1, 2)]
        public RangeNode<byte> UnCompletedTextTransparency { get; set; } = new RangeNode<byte>(255, 0, 255);
        [Menu("Text Bg", 2, 2)]
        public ColorNode UnCompletedTextBg { get; set; } = new Color(0, 0, 0, 1f);
        [Menu("Filled Circle", 3, 2)]
        public ToggleNode UnCompletedFilledCircle { get; set; } = new ToggleNode(true);
        [Menu("Fill Color", 4, 2)]
        public ColorNode UnCompletedFillColor { get; set; } = new Color(0, 0, 0, 0.75f);

        [Menu("Completed Map Settings", 3)]
        public EmptyNode _3 { get; set; }
        // [Menu("Show Completed", 0, 3)]
        // public ToggleNode ShowCompleted { get; set; } = new ToggleNode(true);
        [Menu("Text Transparency", 1, 3)]
        public RangeNode<byte> CompletedTextTransparency { get; set; } = new RangeNode<byte>(255, 0, 255);
        [Menu("Text Bg", 2, 3)]
        public ColorNode CompletedTextBg { get; set; } = new Color(0, 0, 0, 0.75f);
        [Menu("Filled Circle", 3, 3)]
        public ToggleNode CompletedFilledCircle { get; set; } = new ToggleNode(true);
        [Menu("Fill Color", 4, 3)]
        public ColorNode CompletedFillColor { get; set; } = new Color(1f, 0, 0, 0.235f);


        [Menu("Bonus Completed Map Settings", 4)]
        public EmptyNode _4 { get; set; }
        // [Menu("Show Bonus Completed", 0, 4)]
        // public ToggleNode ShowBonusCompleted { get; set; } = new ToggleNode(true);
        [Menu("Text Transparency", 1, 4)]
        public RangeNode<byte> BonusCompletedTextTransparency { get; set; } = new RangeNode<byte>(100, 0, 255);
        [Menu("Text Bg", 2, 4)]
        public ColorNode BonusCompletedTextBg { get; set; } = new Color(0, 0, 0, 0.5f);
        [Menu("Filled Circle", 3, 4)]
        public ToggleNode BonusCompletedFilledCircle { get; set; } = new ToggleNode(true);
        [Menu("Fill Color", 4, 4)]
        public ColorNode BonusCompletedFillColor { get; set; } = new Color(0.1f, 0.9f, 0.1f, 0.01f);

        //[Menu("League")] // gonna use from GameController.Game.IngameState.ServerData.League
        //public ListNode League { get; set; } = new ListNode();
        public ToggleNode Enable { get; set; } = new ToggleNode(false);
    }
}