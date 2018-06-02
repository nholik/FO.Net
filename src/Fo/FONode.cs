using System;
using System.Collections;
using System.Collections.Generic;
using Fonet.Layout;

namespace Fonet.Fo
{
    internal abstract class FONode
    {
        protected FObj parent;

        protected string areaClass = AreaClass.UNASSIGNED;

        protected List<FONode> children = new List<FONode>();

        public const int MarkerStart = -1000;

        public const int MarkerBreakAfter = -1001;

        protected int marker = MarkerStart;

        protected bool isInTableCell = false;

        protected int forcedStartOffset = 0;

        protected int forcedWidth = 0;

        protected int widows = 0;

        protected int orphans = 0;

        protected LinkSet linkSet;

        public int areasGenerated = 0;

        private Func<string, byte[]> _imageHandler;
        public Func<string, byte[]> ImageHandler
        {
            get
            {
                return _imageHandler;
            }
            set
            {
                _imageHandler = value;

                if (children != null)
                {
                    for (int i = 0; i < children.Count; i++)
                    {
                        var node = children[i] as FONode;
                        if (node != null)
                            node.ImageHandler = value;
                    }
                }
            }
        }

        protected FONode(FObj parent)
        {
            this.parent = parent;

            if (null != parent)
            {
                this.areaClass = parent.areaClass;
                _imageHandler = parent.ImageHandler;
            }
        }

        public virtual void SetIsInTableCell()
        {
            isInTableCell = true;
            foreach (FONode child in children)
            {
                child.SetIsInTableCell();
            }
        }

        public virtual void ForceStartOffset(int offset)
        {
            forcedStartOffset = offset;
            foreach (FONode child in children)
            {
                child.ForceStartOffset(offset);
            }
        }

        public virtual void ForceWidth(int width)
        {
            forcedWidth = width;
            foreach (FONode child in children)
            {
                child.ForceWidth(width);
            }
        }

        public virtual void ResetMarker()
        {
            marker = MarkerStart;
            foreach (FONode child in children)
            {
                child.ResetMarker();
            }
        }

        public void SetWidows(int wid)
        {
            widows = wid;
        }

        public void SetOrphans(int orph)
        {
            orphans = orph;
        }

        public void RemoveAreas()
        {
        }

        protected internal virtual void AddChild(FONode child)
        {
            children.Add(child);
        }

        public FObj getParent()
        {
            return parent;
        }

        public virtual void SetLinkSet(LinkSet linkSet)
        {
            this.linkSet = linkSet;
            foreach (FONode child in children)
            {
                child.SetLinkSet(linkSet);
            }
        }

        public virtual LinkSet GetLinkSet()
        {
            return linkSet;
        }

        public abstract Status Layout(Area area);

        public virtual Property GetProperty(String name)
        {
            return null;
        }

        public virtual ArrayList getMarkerSnapshot(ArrayList snapshot)
        {
            snapshot.Add(marker);

            if (marker < 0)
            {
                return snapshot;
            }
            else if (children.Count == 0)
            {
                return snapshot;
            }
            else
            {
                return children[this.marker].getMarkerSnapshot(snapshot);
            }
        }

        public virtual void Rollback(ArrayList snapshot)
        {
            this.marker = (Int32)snapshot[0];
            snapshot.RemoveAt(0);

            if (this.marker == MarkerStart)
            {
                ResetMarker();
                return;
            }
            else if ((this.marker == -1) || children.Count == 0)
            {
                return;
            }

            if (this.marker <= MarkerStart)
            {
                return;
            }

            int numChildren = children.Count;
            for (int i = this.marker + 1; i < numChildren; i++)
            {
                FONode fo = children[i];
                fo.ResetMarker();
            }
            children[this.marker].Rollback(snapshot);
        }

        public virtual bool MayPrecedeMarker()
        {
            return false;
        }
    }
}