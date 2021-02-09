using System;
using ChroDoom.Engine.WAD;
using Chroma;
using Chroma.Diagnostics.Logging;
using Chroma.Graphics;
using Chroma.Input;

namespace ChroDoom
{
    internal class GameCore : Game
    {
        public static Log Log { get; } = LogManager.GetForCurrentAssembly();

        internal GameCore()
        {
            Log.Info(Environment.CurrentDirectory);
            var test = Wad.LoadFromFile(@"../../../WADs/DOOM.WAD");
            Log.Info("Hello, world!");
        }

        protected override void Draw(RenderContext context)
        {
            base.Draw(context);
        }

        protected override void Update(float delta)
        {
            base.Update(delta);
        }

        protected override void FixedUpdate(float delta)
        {
            base.FixedUpdate(delta);
        }

        protected override void LoadContent()
        {
            base.LoadContent();
        }

        protected override void MouseMoved(MouseMoveEventArgs e)
        {
            base.MouseMoved(e);
        }

        protected override void MousePressed(MouseButtonEventArgs e)
        {
            base.MousePressed(e);
        }

        protected override void KeyPressed(KeyEventArgs e)
        {
            base.KeyPressed(e);
        }

        protected override void ControllerConnected(ControllerEventArgs e)
        {
            base.ControllerConnected(e);
        }

        protected override void ControllerDisconnected(ControllerEventArgs e)
        {
            base.ControllerDisconnected(e);
        }

        protected override void ControllerButtonPressed(ControllerButtonEventArgs e)
        {
            base.ControllerButtonPressed(e);
        }

        protected override void ControllerAxisMoved(ControllerAxisEventArgs e)
        {
            base.ControllerAxisMoved(e);
        }
    }
}
