namespace PROJECT_SAFE_NAME
{
    using System;
    
    using Microsoft.Xna.Framework;

    using Protogame;

    public class Dirt : Entity, ITileEntity
    {
        private ITileUtilities m_TileUtilities;

        public int TX { get; set; }
        public int TY { get; set; }
        public bool AppliedTilesetSettings { get; set; }
        public IAssetReference<TilesetAsset> Tileset { get; set; }

        public Dirt(ITileUtilities tileUtilities, float x, float y, int tx, int ty)
        {
            this.m_TileUtilities = tileUtilities;

            this.Transform.LocalPosition = new Vector3(x, y, 0);
            this.TX = tx;
            this.TY = ty;

            this.m_TileUtilities.InitializeTile(this, "tileset.Dirt");
        }

        public override void Render(IGameContext gameContext, IRenderContext renderContext)
        {
            base.Render(gameContext, renderContext);

            this.m_TileUtilities.RenderTile(this, renderContext);
        }
    }
}
