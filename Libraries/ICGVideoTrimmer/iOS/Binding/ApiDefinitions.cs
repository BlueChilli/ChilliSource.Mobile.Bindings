using System;
using AVFoundation;
using CoreGraphics;
using Foundation;

using ObjCRuntime;
using UIKit;

namespace ICGVideoTrimmerBinding
{

    // @interface ICGRulerView : UIView
    [BaseType(typeof(UIView))]
    interface ICGRulerView
    {
        // @property (assign, nonatomic) CGFloat widthPerSecond;
        [Export("widthPerSecond")]
        nfloat WidthPerSecond { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull themeColor;
        [Export("themeColor", ArgumentSemantic.Strong)]
        UIColor ThemeColor { get; set; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));


        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame widthPerSecond:(CGFloat)width themeColor:(UIColor * _Nonnull)color __attribute__((objc_designated_initializer));
        [Export("initWithFrame:widthPerSecond:themeColor:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame, nfloat width, UIColor color);
    }

    // @interface ICGThumbView : UIView
    [BaseType(typeof(UIView))]
    interface ICGThumbView
    {
        // @property (nonatomic, strong) UIColor * _Nullable color;
        [NullAllowed, Export("color", ArgumentSemantic.Strong)]
        UIColor Color { get; set; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));


        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame color:(UIColor * _Nonnull)color right:(BOOL)flag __attribute__((objc_designated_initializer));
        [Export("initWithFrame:color:right:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame, UIColor color, bool flag);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame thumbImage:(UIImage * _Nonnull)image __attribute__((objc_designated_initializer));
        [Export("initWithFrame:thumbImage:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame, UIImage image);
    }

    // @interface ICGVideoTrimmerView : UIView
    [BaseType(typeof(UIView))]
    interface ICGVideoTrimmerView
    {
        // @property (nonatomic, strong) AVAsset * _Nullable asset;
        [NullAllowed, Export("asset", ArgumentSemantic.Strong)]
        AVAsset Asset { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull themeColor;
        [Export("themeColor", ArgumentSemantic.Strong)]
        UIColor ThemeColor { get; set; }

        // @property (assign, nonatomic) CGFloat maxLength;
        [Export("maxLength")]
        nfloat MaxLength { get; set; }

        // @property (assign, nonatomic) CGFloat minLength;
        [Export("minLength")]
        nfloat MinLength { get; set; }

        // @property (assign, nonatomic) BOOL showsRulerView;
        [Export("showsRulerView")]
        bool ShowsRulerView { get; set; }

        // @property (assign, nonatomic) UIColor * _Nonnull trackerColor;
        [Export("trackerColor", ArgumentSemantic.Assign)]
        UIColor TrackerColor { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable leftThumbImage;
        [NullAllowed, Export("leftThumbImage", ArgumentSemantic.Strong)]
        UIImage LeftThumbImage { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable rightThumbImage;
        [NullAllowed, Export("rightThumbImage", ArgumentSemantic.Strong)]
        UIImage RightThumbImage { get; set; }

        // @property (assign, nonatomic) CGFloat borderWidth;
        [Export("borderWidth")]
        nfloat BorderWidth { get; set; }

        // @property (assign, nonatomic) CGFloat thumbWidth;
        [Export("thumbWidth")]
        nfloat ThumbWidth { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        ICGVideoTrimmerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<ICGVideoTrimmerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));


        // -(instancetype _Nonnull)initWithAsset:(AVAsset * _Nonnull)asset;
        [Export("initWithAsset:")]
        IntPtr Constructor(AVAsset asset);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame asset:(AVAsset * _Nonnull)asset __attribute__((objc_designated_initializer));
        [Export("initWithFrame:asset:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame, AVAsset asset);

        // -(void)resetSubviews;
        [Export("resetSubviews")]
        void ResetSubviews();

        // -(void)seekToTime:(CGFloat)startTime;
        [Export("seekToTime:")]
        void SeekToTime(nfloat startTime);

        // -(void)hideTracker:(BOOL)flag;
        [Export("hideTracker:")]
        void HideTracker(bool flag);
    }

        // @protocol ICGVideoTrimmerDelegate <NSObject>
        [Protocol, Model]
        [BaseType(typeof(NSObject))]
        interface ICGVideoTrimmerDelegate
        {
            // @required -(void)trimmerView:(ICGVideoTrimmerView * _Nonnull)trimmerView didChangeLeftPosition:(CGFloat)startTime rightPosition:(CGFloat)endTime;
            [Abstract]
    	[Export ("trimmerView:didChangeLeftPosition:rightPosition:")]
    	void DidChangeLeftPosition (ICGVideoTrimmerView trimmerView, nfloat startTime, nfloat endTime);
    }


}
