using Foundation;
using ObjCRuntime;
using System;

namespace Accessibility
{
	// @interface SSAccessibility : NSObject
	[BaseType(typeof(NSObject))]
	interface SSAccessibility
	{
		// +(void)speakWithVoiceOver:(NSString *)string;
		[Static]
		[Export("speakWithVoiceOver:")]
		void SpeakWithVoiceOver(string @string);
	}

	// @interface SSSpeechSynthesizer : NSObject
	[BaseType(typeof(NSObject))]
	interface SSSpeechSynthesizer
	{
		// @property (readonly, assign, nonatomic) BOOL mayBeSpeaking;
		[Export("mayBeSpeaking")]
		bool MayBeSpeaking { get; }

		// @property (assign, nonatomic) NSTimeInterval timeoutDelay;
		[Export("timeoutDelay")]
		double TimeoutDelay { get; set; }

		[Wrap("WeakDelegate")]
		SSSpeechSynthesizerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<SSSpeechSynthesizerDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)stopSpeaking;
		[Export("stopSpeaking")]
		void StopSpeaking();

		// -(void)continueSpeaking;
		[Export("continueSpeaking")]
		void ContinueSpeaking();

		// -(void)enqueueLineForSpeaking:(NSString *)line;
		[Export("enqueueLineForSpeaking:")]
		void EnqueueLineForSpeaking(string line);
	}

	// @protocol SSSpeechSynthesizerDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface SSSpeechSynthesizerDelegate
	{
		// @optional -(NSTimeInterval)synthesizer:(SSSpeechSynthesizer *)synthesizer secondsToWaitBeforeSpeaking:(NSString *)line;
		[Export("synthesizer:secondsToWaitBeforeSpeaking:")]
		double Synthesizer(SSSpeechSynthesizer synthesizer, string line);

		// @optional -(void)synthesizer:(SSSpeechSynthesizer *)synthesizer willBeginSpeakingLine:(NSString *)line;
		[Export("synthesizer:willBeginSpeakingLine:")]
		void SynthesizerWillSpeak(SSSpeechSynthesizer synthesizer, string line);

		// @optional -(void)synthesizer:(SSSpeechSynthesizer *)synthesizer didSpeakLine:(NSString *)line;
		[Export("synthesizer:didSpeakLine:")]
		void SynthesizerDidSpeak(SSSpeechSynthesizer synthesizer, string line);

		// @optional -(void)synthesizerDidFinishQueue:(SSSpeechSynthesizer *)synthesizer;
		[Export("synthesizerDidFinishQueue:")]
		void SynthesizerDidFinishQueue(SSSpeechSynthesizer synthesizer);
	}

	[Static]
	partial interface Constants
	{
		// extern double SSAccessibilityVersionNumber;
		[Field("SSAccessibilityVersionNumber", "__Internal")]
		double SSAccessibilityVersionNumber { get; }

		// extern const unsigned char [] SSAccessibilityVersionString;
		[Field("SSAccessibilityVersionString", "__Internal")]
		IntPtr SSAccessibilityVersionString { get; }
	}
}
